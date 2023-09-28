<template>
  <div style="margin: 12px 12px">
    <h4 class="text-center fw-bold mb-2">Report Big-Bag</h4>
    <hr class="bg-dark border-2 border-top border-dark" />
    <div class="container fs-4">
      <div class="row mb-5">
        <div class="col">
          <strong>Považský cukor a.s.</strong>
        </div>
      </div>
      <div class="row mb-1">
        <div class="col-3">
          <strong>Obdobie:</strong>
        </div>
        <div class="col-2">
          <strong>Od:</strong>
        </div>
        <div class="col-2">
          {{ state.obdobieOd }}
        </div>
        <div class="col-2">
          <strong>Do:</strong>
        </div>
        <div class="col-2">
          {{ state.obdobieDo }}
        </div>
      </div>
      <div class="row mb-1">
        <div class="col-3">
          <strong>Váha:</strong>
        </div>
        <div class="col-3">
          {{ state.vaha }}
        </div>
      </div>
      <div class="row mb-1">
        <div class="col-3">
          <strong>Program:</strong>
        </div>
        <div class="col-3">
          {{ state.program }}
        </div>
      </div>
      <div class="row mb-1">
        <div class="col-3">
          <strong>Užívateľ:</strong>
        </div>
        <div class="col-3">
          {{ state.uzivatel }}
        </div>
      </div>
      <div class="d-flex justify-content-between row"></div>
    </div>
    <hr class="bg-dark border-2 border-top border-dark" />
    <div class="container fs-4">
      <div class="row">
        <div class="col-3">
          <strong>Hmotnosť spolu (kg):</strong>
        </div>
        <div class="col-3">
          {{ toCurrency(props.sum) }}
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { defineProps, reactive, watch } from 'vue';

const props = defineProps({
  title: String,
  filter: Array,
  sum: Number,
});

const state = reactive({
  obdobieOd: '',
  obdobieDo: '',
  vaha: props.title,
  program: 'Všetky programy',
  uzivatel: 'Všetci užívatelia',
});

const toCurrency = (value) =>
  value != null && value != undefined && !isNaN(value) ? parseFloat(value.toFixed(2)).toLocaleString('sk-SK', { minimumFractionDigits: 1, maximumFractionDigits: 1 }) : '';

const toDate = (value) => {
  if (!value) return '';
  const date = new Date(value).toLocaleString('sk-SK');
  if (date != 'Invalid Date') return date;
  else return '';
    };

watch(
  () => props.title,
  (e) => (state.vaha = e),
);

watch(
  () => props.filter,
  (filter) => {
    state.obdobieOd = null;
    state.obdobieDo = null;
    state.vaha = props.title;
    state.program = 'Všetky programy';
    state.uzivatel = 'Všetci užívatelia';
    console.log(filter);
    if (filter?.length) {
      filter.forEach((e) => {
        if (e && Array.isArray(e)) {
          const firstItem = e[0];
          const secondItem = e[1];
          const thirdItem = e[2];
          if (e.columnIndex == 3 || firstItem == 'casVazenia') {
            if (e.columnIndex) {
              if (e.selectedFilterOperation == 'between') {
                state.obdobieOd = toDate(e.filterValue[0]);
                state.obdobieDo = toDate(e.filterValue[1]);
              } else if (e.selectedFilterOperation == '>' || e.selectedFilterOperation == '>=') {
                state.obdobieOd = toDate(e[2]);
              } else if (e.selectedFilterOperation == '<' || e.selectedFilterOperation == '<=') {
                state.obdobieDo = toDate(e[2]);
                //let date = new Date(e[2]);
                //date.setDate(date.getDate() - 1);
                //state.obdobieDo = toDate(date);
              } else if (e.selectedFilterOperation == '=') {
                state.obdobieOd = toDate(e.filterValue);
                state.obdobieDo = toDate(e.filterValue);
              }
            } else {
              if (secondItem == '>' || secondItem == '>=') {
                state.obdobieOd = toDate(thirdItem);
              } else if (secondItem == '<' || secondItem == '<=') {
                state.obdobieDo = toDate(thirdItem);
                //let date = new Date(thirdItem);
                //date.setDate(date.getDate() - 1);
                //state.obdobieDo = toDate(date);
              }
            }
          } else if (e.columnIndex == 4) {
            state.vaha = e.filterValue;
          } else if (e.columnIndex == 5) {
            state.program = e.filterValue;
          } else if (e.columnIndex == 6) {
            state.uzivatel = e.filterValue;
          }
        } else if (e == 'casVazenia') {
          if (filter[1] == '>' || filter[1] == '>=') {
            state.obdobieOd = toDate(filter[2]);
          } else if (filter[1] == '<' || filter[1] == '<=') {
            state.obdobieDo = toDate(filter[2]);
            //let date = new Date(filter[2]);
            //date.setDate(date.getDate() - 1);
            //state.obdobieDo = toDate(date);
          }
        } else if (e == 'zariadenieNazov') {
          state.vaha = filter[2];
        } else if (e == 'programNazov') {
          state.program = filter[2];
        } else if (e == 'uzivatelNazov') {
          state.uzivatel = filter[2];
        }
      });
    }
    console.log(state);
  },
);
</script>

<style></style>
