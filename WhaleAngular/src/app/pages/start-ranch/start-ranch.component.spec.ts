import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StartRanchComponent } from './start-ranch.component';

describe('StartRanchComponent', () => {
  let component: StartRanchComponent;
  let fixture: ComponentFixture<StartRanchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StartRanchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StartRanchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
