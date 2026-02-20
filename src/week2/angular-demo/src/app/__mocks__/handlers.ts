import { delay, http, HttpHandler, HttpResponse } from 'msw';
import questionHandler from './questions-handler';
const fakeTodos = [
  {
    id: '1',
    title: 'Clean Garage',
    completed: false,
  },
  {
    id: '2',
    title: 'Mocked Todo 2',
    completed: true,
  },
];
export const handlers: HttpHandler[] = [
  http.get('https://jsonplaceholder.typicode.com/todos', async () => {
    await delay(); // 200ms delay to simulate network latency
    return HttpResponse.json(fakeTodos);
  }),
];
