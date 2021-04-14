import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TnavbarNonregComponent } from './tnavbar-nonreg.component';

describe('TnavbarNonregComponent', () => {
  let component: TnavbarNonregComponent;
  let fixture: ComponentFixture<TnavbarNonregComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TnavbarNonregComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TnavbarNonregComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
