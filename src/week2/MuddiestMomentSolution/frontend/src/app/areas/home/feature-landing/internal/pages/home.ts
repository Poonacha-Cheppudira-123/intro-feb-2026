import { ChangeDetectionStrategy, Component } from '@angular/core';
import { PageLayout } from '@ht/shared/ui-common/layouts/page';
import { NgIcon } from '@ng-icons/core';

@Component({
  selector: 'ht-home-home',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [PageLayout, NgIcon],
  template: `
    <app-ui-page title="Muddiest Point">
      <div class="flex flex-row gap-4">
        <div class="flex-1">

        <form>
<div class="flex flex-col gap-4">
  <label class="label">What was the muddiest from today's work?</label>

  <input type="text" class="input input-bordered w-full max-w-xs block" />


</div>
<div class="flex flex-col gap-4 mt-4">
  <label class="label">You can add additional details if you think it would be helpful</label>
 <textarea class="textarea textarea-bordered w-full max-w-xs" placeholder="Additional details..."></textarea>
</div>
<div class="mt-4">
  <button class="btn btn-primary">Submit</button>
</div>
</form>

</div>
<div class="w-1/4">
  <ul class="menu bg-base-100 w-full gap-8">
    <li class="menu-title">
      <span>Previous Submissions</span>
    </li>
    <li class="flex flex-row gap-2"><a>Submission 1</a><button class="btn btn-xs btn-circle btn-primary"><ng-icon color="white" size="12pt"name="lucidePencilLine" /></button><button class="btn btn-xs btn-circle btn-error"><ng-icon name="lucideCircleX" color="white" size="14pt" /></button></li>
    <li class="flex flex-row gap-2"><a>Submission 2</a><button class="btn btn-xs btn-circle btn-primary"><ng-icon color="white" size="12pt"name="lucidePencilLine" /></button><button class="btn btn-xs btn-circle btn-error"><ng-icon name="lucideCircleX" color="white" size="14pt" /></button></li>
  </ul>
</div>
</div>
    </app-ui-page>
  `,
  styles: ``,
})
export class HomePage {}
