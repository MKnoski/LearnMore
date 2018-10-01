import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { Test } from '../../../models/create-test/test';
import { NewTestService } from '../../../services/new-test.service';

@Component({
  selector: 'lm-create-test-form',
  templateUrl: './create-test-form.component.html',
  styleUrls: ['./create-test-form.component.css']
})
export class CreateTestFormComponent implements OnInit {

  public createTestForm: FormGroup;

  private readonly formBuilder: FormBuilder;
  private readonly newTestService: NewTestService;

  constructor(formBuilder: FormBuilder, newTestService: NewTestService) {
    this.formBuilder = formBuilder;
    this.newTestService = newTestService;
  }

  public ngOnInit(): void {
    this.createTestForm = this.formBuilder.group({
      title: ['', Validators.required],
      description: ['', Validators.required],
      questions: this.formBuilder.array([])
    });
  }

  public addQuestion(): void {
    const questionControls = <FormArray>this.createTestForm.controls.questions;
    questionControls.push(this.initQuestion());
  }

  public onSubmit({ test, valid }: { test: Test, valid: boolean }): void {
    event.preventDefault();
    console.log('Is form valid? - ' + valid);
    test.questions.forEach(q => q.answers.forEach((a, id) => a.isCorrect = id === q.correctAnswerId));

    if (valid) {
      this.newTestService.SaveNewTest(test);
    }
  }

  private initQuestion(): FormGroup {
    return this.formBuilder.group({
      type: [''],
      contents: [''],
      correctAnswerId: [ null ],
      answers: this.formBuilder.array([])
    });
  }
}
