import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'lm-new-answer',
  templateUrl: './new-answer.component.html',
  styleUrls: ['./new-answer.component.css']
})
export class NewAnswerComponent implements OnInit {

  @Input() public answerForm: FormGroup;
  @Input() public questionId: number;
  @Input() public answerId: number;

  public ngOnInit(): void  {
  }
}
