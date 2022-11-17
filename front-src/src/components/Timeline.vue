<script lang="ts">
import { defineComponent } from 'vue'
import { useQuasar, QSpinnerPuff } from 'quasar'
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
    const $q = useQuasar();
    $q.loading.show({
      message: 'Fetching data. Hang on...',
      spinner: QSpinnerPuff
    });
    try {
      const { data } = await axios.get('/api/events');
      this.yearsWithEvents = data;
    } finally {
      $q.loading.hide();
    }
  }
})
</script>

<template>
  <div class="q-px-lg q-pb-md">
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
