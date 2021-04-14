import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewOffsetJobComponent } from './new-offset-job.component';

describe('NewOffsetJobComponent', () => {
  let component: NewOffsetJobComponent;
  let fixture: ComponentFixture<NewOffsetJobComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewOffsetJobComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewOffsetJobComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
