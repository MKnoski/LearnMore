import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MyTestsPageComponent } from './my-tests-page.component';

describe('MyTestsPageComponent', () => {
  let component: MyTestsPageComponent;
  let fixture: ComponentFixture<MyTestsPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyTestsPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MyTestsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
