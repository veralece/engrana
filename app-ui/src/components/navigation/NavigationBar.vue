<template>
  <nav class="navbar navbar-sticky sticky">
    <section class="navbar-start">
      <router-link :to="{ name: 'home' }">
        <img class="logo" src="/logo.webp" alt=""></router-link>
    </section>

    <section class="navbar-end flex gap-8">
      <router-link v-if="store.user == null" :to="{ name: 'login' }"
        class="text-sm btn btn-solid-primary">Login</router-link>

      <div v-else class="avatar avatar-ring">
        <label for="drawer-right" class="btn btn-ghost flex cursor-pointer px-0" tabindex="0">
          <UserIcon />
        </label>
      </div>

      <input v-model="showDrawer" type="checkbox" id="drawer-right" class="drawer-toggle" />
      <label class="overlay" for="drawer-right"></label>
      <div @click="showDrawer = false" class="drawer drawer-right">
        <div v-if="store.user != null" class="drawer-content pt-10 pb-0 px-0 flex flex-col h-svh place-content-between">
          <label class="btn btn-sm btn-circle btn-ghost absolute right-2 top-2">✕</label>
          <ul class="flex flex-col pt-5">
            <!-- <NavLinks /> -->
          </ul>
          <a @click="handleSignOut" class="text-sm btn btn-xl hover:btn-primary rounded-none">Logout</a>
        </div>
      </div>
    </section>
    <!-- <Updates /> -->
  </nav>
</template>

<script setup lang="ts">
import { ref } from 'vue';
import { useUserStore } from '@/stores/';
// import { useRouter } from 'vue-router';
import UserIcon from '@/components/icons/IconUser.vue';
// import Updates from '@/components/responses/Updates.vue';
// import NavLinks from '@/components/navigation/NavLinks.vue';
const store = useUserStore();
const showDrawer = ref(false);
// const router = useRouter();
const handleSignOut = () => {
  // store.signOutUser();
  // router.push({ name: 'login' });
}
</script>

<style scoped>
.logo {
  max-width: 32px;
}
</style>
