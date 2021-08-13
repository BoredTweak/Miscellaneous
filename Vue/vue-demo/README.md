# Vue 3 + Typescript + Vite

This application was generated in part by following [this documentation](https://v3.vuejs.org/guide/introduction.html) by running `npm init @vitejs/app vuejs-spike` and selecting the following options:

√ Select a framework: » vue
√ Select a variant: » vue-ts

## Prerequisites

#### NPM and Node

Install the latest version [here](https://nodejs.org/en/)

#### Vue CLI

Install the Vue CLI by running `npm install -g @vue/cli`.

## Running Locally

Install dependencies via `npm install` then run this application via `npm run dev`.

## Demo Goals

### Components

Demonstrated out of the box via [HelloWorld.vue](src/components/HelloWorld.vue) and it's use in [App.vue](src/App.vue).

See [here for more information](https://v3.vuejs.org/guide/component-registration.html)

### Directives

- Iteration with `v-for`
  - Demonstrated in [App.vue](src/App.vue)
  - See [here for more information](https://v3.vuejs.org/guide/introduction.html#conditionals-and-loops)
- Conditional Rendering with `v-if`
  - Demonstrated in [Conditional.vue](src/components/Conditional.vue)
  - See [here for more information](https://v3.vuejs.org/api/directives.html#v-if)

### Lifecycle Hooks

There are several points in the component rendering lifecycle of Vue wherein developers can crete hooks.

See [here for more information](https://v3.vuejs.org/guide/instance.html#lifecycle-hooks)

### Design Intent

`"...it is important for us to agree that separation of concerns is not equal to separation of file types. The ultimate goal of engineering principles is to improve maintainability of codebases. Separation of concerns, when applied dogmatically as separation of file types, does not help us reach that goal in the context of increasingly complex frontend applications."`

See [here for more information](https://v3.vuejs.org/guide/single-file-component.html#what-about-separation-of-concerns)

### Routing

Routing is not provided by default, but there is an officially supported npm library `vue-router`.

See [here for more information](https://v3.vuejs.org/guide/routing.html)

## Type Support For `.vue` Imports in TS

Since TypeScript cannot handle type information for `.vue` imports, they are shimmed to be a generic Vue component type by default. In most cases this is fine if you don't really care about component prop types outside of templates. However, if you wish to get actual prop types in `.vue` imports (for example to get props validation when using manual `h(...)` calls), you can use the following:
