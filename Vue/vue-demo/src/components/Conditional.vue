<template>
  <h1>{{ visible }}</h1>
  <div v-if="visible == true">Peekaboo!</div>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
export default defineComponent({
  name: 'Conditional',
  props: {
    visible: {
      type: Boolean,
      required: true
    }
  }
})
</script>
