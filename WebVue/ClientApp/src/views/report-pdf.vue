<template>
  <div style="margin: 12px 12px">
    <h1 class="test-results-header">Big-Bag report</h1>
  </div>
</template>

<script setup>
import { defineProps } from 'vue';

const props = defineProps({
  title: String,
  filter: Function,
  sum: Number,
});
</script>

<style></style>
