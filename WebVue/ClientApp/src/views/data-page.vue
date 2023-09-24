<template>
  <div>
    <div class="d-flex justify-content-between">
      <div class="d-flex justify-content-start">
        <h2 class="content-block">{{ title }}</h2>
        <button type="button" class="btn btn-primary h-50 m-3" @click="reloadData">Obnoviť</button>
      </div>
      <button type="button" class="btn btn-secondary h-100 m-3" @click="exportToPdf">Exportovať</button>
    </div>

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
      :on-content-ready="onContentReady"
      :on-row-removing="onRowRemoving"
    >
      <dx-paging :page-size="10" />
      <dx-pager :show-page-size-selector="true" :show-info="true" :allowed-page-sizes="[5, 10, 20, 50, 100]" />
      <dx-filter-row :visible="true" />
      <dx-editing :allow-adding="false" :allow-updating="false" :allow-deleting="true" :confirm-delete="true" />
      <dx-column caption="Riadok" :allow-search="false" :allow-sorting="false" :alignment="'right'" cell-template="poradieTemplate" />
      <dx-column data-field="id" caption="Id" :visible="false" />
      <dx-column data-field="vaha" caption="Hmotnosť (kg)" data-type="number" :format="floatFormat" />
      <dx-column data-field="casVazenia" caption="Čas váženia" data-type="date" :format="dateFormat" />
      <dx-column data-field="zariadenieNazov" caption="Váha" :visible="!state.zariadenie" />
      <dx-column data-field="programNazov" caption="Program" />
      <!-- <dx-column data-field="programCislo" caption="Číslo programu" :width="130" /> -->
      <dx-column data-field="uzivatelNazov" caption="Užívateľ" />
      <!-- <dx-column data-field="uzivatelCislo" caption="Číslo užívateľa" :width="130" /> -->
      <dx-column data-field="casVycitania" caption="Čas vyčítania dát" data-type="date" :format="dateFormat" />
      <!-- <dx-column data-field="Task_Priority" caption="Priority">
        <dx-lookup display-expr="name" value-expr="value" :data-source="priorities" />
      </dx-column> -->
      <DxSummary>
        <DxTotalItem column="vaha" summary-type="sum" :value-format="bigFloatFormat" />
      </DxSummary>
      <template #poradieTemplate="{ data }">{{ calculatePoradie(data.row.rowIndex) }}</template>
    </dx-data-grid>
  </div>
  <div>
    <vue3-html2pdf
      :show-layout="false"
      :float-layout="true"
      :enable-download="true"
      :preview-modal="true"
      :paginate-elements-by-height="1400"
      filename="nightprogrammerpdf"
      :pdf-quality="2"
      :manual-pagination="false"
      pdf-format="a4"
      :pdf-margin="10"
      pdf-orientation="landscape"
      pdf-content-width="1100px"
      ref="html2pdfRef"
    >
      <template v-slot:pdf-content>
        <ReportPdf :title="vaha" :filter="state.combinedFilter" :sum="state.vahaSum" />
      </template>
    </vue3-html2pdf>
  </div>
</template>

<script setup>
import 'devextreme/data/odata/store';
import DxDataGrid, { DxColumn, DxFilterRow, DxPager, DxPaging, DxTotalItem, DxSummary, DxEditing } from 'devextreme-vue/data-grid';
import DataSource from 'devextreme/data/data_source';
import { createStore } from 'devextreme-aspnet-data-nojquery';
import { computed, reactive, ref, watch } from 'vue';
import { useRoute } from 'vue-router';

import Vue3Html2pdf from 'vue3-html2pdf';
import ReportPdf from './report-pdf';

const route = useRoute();

const floatFormat = '#,##0.00';
const bigFloatFormat = '#,##0.00';
const dateFormat = 'd.M.yyyy H:mm';

const title = computed(() => {
  if (state.zariadenie) {
    if (state.zariadenie > 0 && state.zariadenie <= 3) return `Váženia váhy ${state.zariadenie}`;
    else return 'Žiadne údaje';
  } else return 'Všetky váženia';
});

const vaha = computed(() => {
  if (state.zariadenie) {
    if (state.zariadenie > 0 && state.zariadenie <= 3) return `Váha ${state.zariadenie}`;
    else return 'Žiadne údaje';
  } else return 'Všetky váhy';
});

const html2pdfRef = ref();

const state = reactive({
  dataSource: new DataSource({
    store: createStore({
      key: 'id',
      loadUrl: '/zaznamy',
      deleteUrl: '/zaznamy',
      onBeforeSend: (operation, settings) => {
        if (state.zariadenie) {
          const zariadenieFilter = ['zariadenieId', '=', state.zariadenie];
          const arrayFilter = settings.data.filter ? [JSON.parse(settings.data.filter), 'and', zariadenieFilter] : zariadenieFilter;
          settings.data.filter = JSON.stringify(arrayFilter);
        }
        if (operation === 'delete') {
          settings.data = '';
          settings.url += `?id=${state.actualRowId}`;
        }
      },
    }),
  }),
  dataGridInstance: null,
  zariadenie: route.query.vaha,
  vahaSum: 0,
  combinedFilter: [],
  actualRowId: null,
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

function onContentReady() {
  state.vahaSum = state.dataGridInstance?.getTotalSummaryValue('vaha');
  state.combinedFilter = state.dataGridInstance?.getCombinedFilter();
}

function exportToPdf() {
  try {
    html2pdfRef.value.generatePdf();
  } catch (e) {
    console.log(e);
  }
}

function reloadData() {
  state.dataSource.reload();
}

function onRowRemoving(e) {
  state.actualRowId = e.key;
}

const calculatePoradie = (rowIndex) => rowIndex + state.dataGridInstance.pageIndex() * state.dataGridInstance.pageSize();
</script>
