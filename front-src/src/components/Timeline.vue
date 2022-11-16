<script lang="ts">
import { defineComponent } from 'vue'
import type { PropType } from 'vue'
import axios from 'axios';

interface EventDto {
  title: string
  date: Date,
  description: string,
  noteful: boolean
}

interface YearWithEventsDto {
  year: number,
  events: EventDto[]
}

export default defineComponent({
  data() {
    return {
      yearsWithEvents: [] as YearWithEventsDto[]
    }
  },
  async mounted(): Promise<void> {
    const { data } = await axios.get('/api/events');
    this.yearsWithEvents = data;
  }
})
</script>

<template>
  <div v-if="!yearsWithEvents.length">Loading...</div>
  <div v-else class="q-px-lg q-pb-md">
    <q-timeline color="secondary">
      <template v-for="entry in yearsWithEvents">
        <q-timeline-entry heading>
          {{ entry.year }}
        </q-timeline-entry>
        <q-timeline-entry
          v-for="event in entry.events"
          :title="event.title"
          :subtitle="new Intl.DateTimeFormat('default', {month: 'long'}).format(new Date(event.date))"
          v-bind:color="event.noteful ? 'orange' : ''"
          v-bind:icon="event.noteful ? 'rocket_launch' : ''"
        >
          <div>
            {{event.description}}
          </div>
        </q-timeline-entry>
      </template>
    </q-timeline>
  </div>
</template>

<style scoped>
</style>
