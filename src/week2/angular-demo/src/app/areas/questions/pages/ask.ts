import { Component, ChangeDetectionStrategy, signal } from '@angular/core';
import { QuestionSubmissionItem } from '../types';
import { FormField, form, required, minLength, maxLength } from '@angular/forms/signals';

@Component({
  selector: 'app-questions-ask',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [FormField],
  template: `
    <form (submit)="handleSubmit($event)" novalidate>
      <fieldset class="fieldset">
        <legend class="fieldset-legend">Title of the Question?</legend>
        <input [formField]="form.title" type="text" class="input" placeholder="Type here" />
        @if (form.title().invalid() && form.title().touched()) {
          <div class="alert alert-error">
            <p>Problems</p>
          </div>
        }
        <p class="label">Short description</p>
      </fieldset>
      <fieldset class="fieldset">
        <legend class="fieldset-legend">Description</legend>
        <textarea [formField]="form.content" class="textarea" placeholder="Type here"></textarea>
        <p class="label">Bigger description of your question</p>
      </fieldset>
      <button type="submit" class="btn btn-primary">Submit Question</button>
    </form>
  `,
  styles: ``,
})
export class Ask {
  handleSubmit(event: SubmitEvent) {
    event.preventDefault();
    console.log(this.model());
    if (this.form().valid()) {
      // send the form to the server
    } else {
      // show the errors and stuff.
    }
  }
  model = signal<QuestionSubmissionItem>({
    title: '',
    content: '',
  });

  form = form(this.model, (schemata) => {
    required(schemata.title);
    minLength(schemata.title, 5);
    maxLength(schemata.title, 100);
    required(schemata.content);
    minLength(schemata.content, 10);
    maxLength(schemata.content, 1000);
  });
}
