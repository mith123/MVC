import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DatabaceComponent } from './databace.component';

describe('DatabaceComponent', () => {
  let component: DatabaceComponent;
  let fixture: ComponentFixture<DatabaceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DatabaceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DatabaceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
