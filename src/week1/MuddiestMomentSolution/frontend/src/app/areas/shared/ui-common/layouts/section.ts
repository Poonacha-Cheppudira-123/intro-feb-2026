import { Component, input } from '@angular/core';
import { Route, RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { Icon } from '../icons/icon';
export type SectionLink = Pick<Route, 'path' | 'title'>;
@Component({
  selector: 'app-ui-section-layout',

  template: `
    <!-- Navbar -->
    <nav class="navbar w-full bg-linear-to-r from-base-300 to-base-200">
      <div class="flex flex-row gap-2 justify-items-center items-center">
        <label for="my-drawer-4" aria-label="open sidebar" class="btn btn-circle btn-ghost btn-sm">
          <!-- Sidebar toggle icon -->
          <app-ui-icon name="lucideChevronsUpDown" class="size-4 rotate-90" />
        </label>
        <a
          routerLink="."
          class=" text-base-content font-bold btn btn-ghost mr-2"
          [routerLinkActive]="['btn-active']"
          [routerLinkActiveOptions]="{ exact: true }"
          >{{ title() }}</a
        >
        @if (links() && links()!.length > 0) {
          <div class="flex-1">
            <ul class="flex flex-row gap-2 justify-items-end items-end">
              @for (link of links(); track link.path) {
                <li>
                  <a
                    [routerLink]="link.path"
                    class="font-extralight text-xs btn btn-ghost btn-sm"
                    routerLinkActive="btn-active"
                    >{{ link.title }}</a
                  >
                </li>
              }
            </ul>
          </div>
        }
      </div>
    </nav>
    <!-- Page content here -->
    <div class="h-full"><router-outlet /></div>
  `,
  imports: [RouterOutlet, Icon, RouterLink, RouterLinkActive],
})
export class SectionLayout {
  title = input.required<string>();
  links = input<Array<SectionLink> | null>(null);
}
