import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appLazyLoad]'
})
export class LazyLoad {

  constructor(private el: ElementRef) {}

  @HostListener('mouseenter')
  onMouseEnter() {
    this.el.nativeElement.style.opacity = '0.8';
  }

  @HostListener('mouseleave')
  onMouseLeave() {
    this.el.nativeElement.style.opacity = '1';
  }
}