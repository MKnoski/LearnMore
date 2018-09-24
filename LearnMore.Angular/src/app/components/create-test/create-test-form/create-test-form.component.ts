import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { Test } from '../../../models/create-test/test';

@Component({
  selector: 'lm-create-test-form',
  templateUrl: './create-test-form.component.html',
  styleUrls: ['./create-test-form.component.css']
})
export class CreateTestFormComponent implements OnInit {

  public createTestForm: FormGroup;

  constructor(private readonly formBuilder: FormBuilder) { }

  public ngOnInit(): void {
    this.createTestForm = this.formBuilder.group({
      title: ['', Validators.required],
      description: ['', Validators.required],
      questions: this.formBuilder.array([])
    });

    this.createTestForm.valueChanges.subscribe(s => console.log(s));
  }

  public addQuestion(): void {
    const questionControls = <FormArray>this.createTestForm.controls.questions;
    questionControls.push(this.initQuestion());
  }

  public onSubmit({ value, valid }: { value: Test, valid: boolean }): void {
    event.preventDefault();
    console.log(value, valid);
    console.log(this.createTestForm);
  }

  private initQuestion(): FormGroup {
    return this.formBuilder.group({
      type: [''],
      question: [''],
      answers: this.formBuilder.array([])
    });
  }

}
