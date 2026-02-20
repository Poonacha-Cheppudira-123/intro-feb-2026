import { httpResource } from '@angular/common/http';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
  selector: 'app-basics-resource-demo',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    @if (todosResource.isLoading()) {
      <span class="loading loading-bars loading-xs"></span>
      <span class="loading loading-bars loading-sm"></span>
      <span class="loading loading-bars loading-md"></span>
      <span class="loading loading-bars loading-lg"></span>
      <span class="loading loading-bars loading-xl"></span>
    } @else {
      <ul>
        @for (todo of todosResource.value(); track todo.id) {
          <li>
            <strong>[{{ todo.completed ? 'x' : ' ' }}]</strong>
            {{ todo.title }}
          </li>
        }
      </ul>
    }
  `,
  styles: ``,
})
export class ResourceDemo {
  todosResource = httpResource<{ id: string; title: string; completed: boolean }[]>(
    () => 'https://jsonplaceholder.typicode.com/todos',
  );
}
