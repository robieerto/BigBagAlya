<template>
  <div>
    <h2 class="content-block">{{ title }}</h2>

    <dx-data-grid
      class="dx-card wide-card"
      :data-source="state.dataSource"
      :show-borders="false"
      :focused-row-enabled="true"
      :auto-navigate-to-focused-row="false"
      :column-auto-width="true"
      :column-hiding-enabled="true"
      :show-column-lines="true"
      :show-row-lines="true"
      :word-wrap-enabled="true"
      :remote-operations="true"
      :on-initialized="onDataGridInitialized"
    >
      <dx-paging :page-size="10" />
      <dx-pager :show-page-size-selector="true" :show-info="true" />
      <dx-filter-row :visible="true" />
      <dx-column caption="Riadok" :allow-search="false" :allow-sorting="false" :alignment="'right'" cell-template="poradieTemplate" />
      <dx-column data-field="id" caption="Id" :visible="false" />
      <dx-column data-field="vaha" caption="Váha" :format="floatFormat" />
      <dx-column data-field="casVazenia" caption="Čas váženia" data-type="date" :format="dateFormat" />
      <dx-column data-field="zariadenieNazov" caption="Zariadenie" :visible="!state.zariadenie" />
      <dx-column data-field="programNazov" caption="Program" />
      <!-- <dx-column data-field="programCislo" caption="Číslo programu" :width="130" /> -->
      <dx-column data-field="uzivatelNazov" caption="Užívateľ" />
      <!-- <dx-column data-field="uzivatelCislo" caption="Číslo užívateľa" :width="130" /> -->
      <dx-column data-field="casVycitania" caption="Čas vyčítania dát" data-type="date" :format="dateFormat" />
      <!-- <dx-column data-field="Task_Priority" caption="Priority">
        <dx-lookup display-expr="name" value-expr="value" :data-source="priorities" />
      </dx-column> -->
      <template #poradieTemplate="{ data }">{{ calculatePoradie(data.row.rowIndex) }}</template>
    </dx-data-grid>
  </div>
</template>

<script setup>
import 'devextreme/data/odata/store';
import DxDataGrid, { DxColumn, DxFilterRow, DxPager, DxPaging } from 'devextreme-vue/data-grid';
import DataSource from 'devextreme/data/data_source';
import { createStore } from 'devextreme-aspnet-data-nojquery';
import { computed, reactive, watch } from 'vue';
import { useRoute } from 'vue-router';

const route = useRoute();

const floatFormat = '#0.0';
const dateFormat = 'd.M.yyyy H:mm';

const title = computed(() => {
  if (state.zariadenie) {
    if (state.zariadenie > 0 && state.zariadenie <= 3) return `Váženia zariadenia ${state.zariadenie}`;
    else return 'Žiadne údaje';
  } else return 'Všetky váženia';
});

const state = reactive({
  dataSource: new DataSource({
    store: createStore({
      key: 'id',
      loadUrl: '/zaznamy',
      onBeforeSend: (_, settings) => {
        if (state.zariadenie) {
          const zariadenieFilter = ['zariadenieId', '=', state.zariadenie];
          const arrayFilter = settings.data.filter ? [JSON.parse(settings.data.filter), 'and', zariadenieFilter] : zariadenieFilter;
          settings.data.filter = JSON.stringify(arrayFilter);
        }
      },
    }),
  }),
  dataGridInstance: null,
  zariadenie: null,
});

watch(
  () => route.query,
  () => {
    state.zariadenie = route.query.zariadenie;
    state.dataSource.reload();
  },
);

function onDataGridInitialized(e) {
  state.dataGridInstance = e.component;
}

const calculatePoradie = (rowIndex) => rowIndex + state.dataGridInstance.pageIndex() * state.dataGridInstance.pageSize();
</script>
