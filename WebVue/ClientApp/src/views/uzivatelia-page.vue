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
      :width="'40%'"
    >
      <dx-paging :page-size="10" />
      <dx-pager :show-page-size-selector="true" :show-info="true" />
      <dx-filter-row :visible="true" />
      <!-- <dx-column caption="Riadok" :allow-search="false" :allow-sorting="false" :alignment="'right'" cell-template="poradieTemplate" /> -->
      <dx-column data-field="id" caption="Id" :visible="false" />
      <dx-column data-field="cislo" caption="Číslo užívateľa" :width="'auto'" />
      <dx-column data-field="nazov" caption="Názov užívateľa" />
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

const title = computed(() => {
  if (state.zariadenie) {
    if (state.zariadenie > 0 && state.zariadenie <= 3) return `Užívatelia váhy ${state.zariadenie}`;
    else return 'Žiadne údaje';
  } else return 'Všetci užívatelia';
});

const state = reactive({
  dataSource: new DataSource({
    store: createStore({
      key: 'id',
      loadUrl: '/uzivatelia',
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
  zariadenie: route.query.vaha,
});

watch(
  () => route.query,
  () => {
    state.zariadenie = route.query.vaha;
    state.dataSource.reload();
  },
);

function onDataGridInitialized(e) {
  state.dataGridInstance = e.component;
}

const calculatePoradie = (rowIndex) => rowIndex + state.dataGridInstance.pageIndex() * state.dataGridInstance.pageSize();
</script>
