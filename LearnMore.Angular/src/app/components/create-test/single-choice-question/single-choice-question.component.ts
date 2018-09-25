import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormArray, FormBuilder } from '@angular/forms';
import { Dropdown } from '../../../models/shared/dropdown';
import { DropdownOption } from '../../../models/shared/dropdown-option';

@Component({
  selector: 'lm-single-choice-question',
  templateUrl: './single-choice-question.component.html',
  styleUrls: ['./single-choice-question.component.css']
})
export class SingleChoiceQuestionComponent implements OnInit {

  @Input() public questionForm: FormGroup;
  @Input() public questionId: number;

  private readonly dropdown: Dropdown;
  private readonly formBuilder: FormBuilder;

  constructor(formBuilder: FormBuilder) {

    this.formBuilder = formBuilder;
    this.dropdown = new Dropdown();
    this.dropdown.header = 'Select type';
    this.dropdown.options = [
      new DropdownOption('Single choice', true),
      new DropdownOption('Multiple choice', false)
    ];
   }

  public ngOnInit(): void {
  }

  public addAnswer(): void {
    const answersControls = <FormArray>this.questionForm.controls.answers;
    answersControls.push(this.initAnswers());
  }

  private initAnswers(): FormGroup {
    const answerControl  = this.formBuilder.group({
      value: ['']
    });

    return answerControl;
  }
}
