import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateNewTestPageComponent } from './create-new-test-page.component';

describe('CreateNewTestPageComponent', () => {
  let component: CreateNewTestPageComponent;
  let fixture: ComponentFixture<CreateNewTestPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateNewTestPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateNewTestPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
