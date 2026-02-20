import { httpResource } from '@angular/common/http';
import { Component, ChangeDetectionStrategy, signal, inject } from '@angular/core';
import { QuestionListItem } from '../types';
import { QuestionStore } from '../question-store';

@Component({
  selector: 'app-questions-list',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    @if (store.questionResource.isLoading()) {
      <span class="loading loading-bars loading-xl"></span>
    } @else {
      <ul class="flex flex-col gap-4">
        @for (q of store.questionResource.value(); track q.id) {
          <li class="card bg-base-200 card-xl shadow-sm">
            <div class="card-body">
              <h2 class="card-title">{{ q.title }}</h2>
              <p>{{ q.content }}</p>
              <div class="justify-end card-actions">
                <button class="btn btn-primary">I Have an Answer!</button>
              </div>
            </div>
            @if (q.submittedAnswers) {
              <ul class="flex flex-col gap-2 p-8">
                @for (a of q.submittedAnswers; track a.id) {
                  <li class="card bg-base-100 card-lg shadow-sm p-4 m-8">
                    <p>
                      {{ a.content }}
                    </p>
                  </li>
                }
              </ul>
            }
          </li>
        } @empty {
          <div class="alert alert-info">
            <p>There are no questions! Add one?</p>
          </div>
        }
      </ul>
    }
  `,
  styles: ``,
})
export class List {
  // listResource = httpResource<QuestionListItem[]>(() => '/api/questions');
  store = inject(QuestionStore);
}
