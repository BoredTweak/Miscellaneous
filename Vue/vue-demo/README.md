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

## Type Support For `.vue` Imports in TS

Since TypeScript cannot handle type information for `.vue` imports, they are shimmed to be a generic Vue component type by default. In most cases this is fine if you don't really care about component prop types outside of templates. However, if you wish to get actual prop types in `.vue` imports (for example to get props validation when using manual `h(...)` calls), you can use the following:
