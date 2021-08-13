<template>
  <img alt="Vue logo" src="./assets/logo.png" />
  <HelloWorld msg="Hello Vue 3 + TypeScript + Vite" />
  <div>
    <ul>
      <li v-bind:key="index" v-for="item, index in items">{{index}} - {{item}}</li>
    </ul>
  </div>
  <div>
    <Conditional visible />
    <Conditional visible=false />
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue'
import HelloWorld from './components/HelloWorld.vue'
import Conditional from './components/Conditional.vue'

export interface DemoData {
  items: string[];
}

export default defineComponent({
  name: 'App',
  data(): DemoData { 
    return { items: ['banana', 'apple', 'orange', 'pineapple'] };
  },
  components: {
    HelloWorld,
    Conditional
  }
})
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
