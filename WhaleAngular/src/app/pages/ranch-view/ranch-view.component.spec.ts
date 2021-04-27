import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RanchViewComponent } from './ranch-view.component';

describe('RanchViewComponent', () => {
  let component: RanchViewComponent;
  let fixture: ComponentFixture<RanchViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RanchViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RanchViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
