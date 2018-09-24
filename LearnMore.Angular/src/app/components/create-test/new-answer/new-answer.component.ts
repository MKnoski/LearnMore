import { Component, OnInit, Input, SimpleChanges } from '@angular/core';
import { FormGroup, FormArray, ControlValueAccessor } from '@angular/forms';

@Component({
  selector: 'lm-new-answer',
  templateUrl: './new-answer.component.html',
  styleUrls: ['./new-answer.component.css']
})
export class NewAnswerComponent implements OnInit {

  @Input() public answerForm: FormGroup;

  public isAnswerCorrect: boolean;

  public ngOnInit(): void  {

    this.isAnswerCorrect = true;

  }
}
