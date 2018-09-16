import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchAPIComponent } from './search-api.component';

describe('SearchAPIComponent', () => {
  let component: SearchAPIComponent;
  let fixture: ComponentFixture<SearchAPIComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SearchAPIComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchAPIComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
