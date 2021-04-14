import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewFlexoJobComponent } from './new-flexo-job.component';

describe('NewFlexoJobComponent', () => {
  let component: NewFlexoJobComponent;
  let fixture: ComponentFixture<NewFlexoJobComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewFlexoJobComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewFlexoJobComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
