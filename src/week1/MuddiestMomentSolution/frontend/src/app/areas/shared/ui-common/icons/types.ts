import {
  lucideFoldHorizontal,
  lucideHome,
  lucideSettings,
  lucideUnfoldHorizontal,
  lucideArrowRightFromLine,
  lucideHelpCircle,
  lucideChevronsUpDown,
  lucideCode,
  lucideContainer,
  lucideUserRoundCog,
  lucidePencilLine,
  lucidePencilOff,
  lucideLightbulb,
  lucideBook,
  lucidePackage,
  lucideTestTubeDiagonal,
  lucideWrench,
  lucideCircleX,
} from '@ng-icons/lucide';

export const icons = {
  lucideHome,
  lucideSettings,
  lucideCode,
  lucideFoldHorizontal,
  lucideUnfoldHorizontal,
  lucideArrowRightFromLine,
  lucideHelpCircle,
  lucideChevronsUpDown,
  lucideContainer,
  lucideUserRoundCog,
  lucidePencilLine,
  lucidePencilOff,
  lucideLightbulb,
  lucideBook,
  lucidePackage,
  lucideTestTubeDiagonal,
  lucideWrench,
  lucideCircleX
} as const;

export type IconName = keyof typeof icons;
