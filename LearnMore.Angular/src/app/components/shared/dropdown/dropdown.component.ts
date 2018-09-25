import { Component, OnInit, Input } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Dropdown } from '../../../models/shared/dropdown';

@Component({
  selector: 'lm-dropdown',
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent implements OnInit {

  @Input() public dropdown: Dropdown;
  @Input() public dropdownFormControl: FormControl;

  public ngOnInit(): void {
  }

  public dropdownOptionOnClick(option: string): void {
    this.dropdown.header = option;
    this.dropdownFormControl.setValue(option);
  }
}
