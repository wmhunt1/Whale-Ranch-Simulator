import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaddockViewComponent } from './paddock-view.component';

describe('PaddockViewComponent', () => {
  let component: PaddockViewComponent;
  let fixture: ComponentFixture<PaddockViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PaddockViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PaddockViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
