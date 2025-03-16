import { ref, computed } from 'vue'
import { defineStore } from 'pinia'
import type { IUser } from '@/domain/types'

export const useUserStore = defineStore('user', () => {
  //state
  const isLoading = ref<boolean>(false)
  const loadingMessage = ref<string | null>(null)
  const data = ref<IUser | null>(null)
  // const profileData = ref<IProfile | null>(null)
  const error = ref<string | null>(null)

  // getters
  const user = computed(() => data.value)

  return { error, isLoading, loadingMessage, user }
})
