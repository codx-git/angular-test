import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { moduleAComponent } from './module-a.component';

describe('moduleAComponent', () => {
  let component: moduleAComponent;
  let fixture: ComponentFixture<moduleAComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ moduleAComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(moduleAComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
