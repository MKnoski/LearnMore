import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';

@Component({
  selector: 'lm-create-test-form',
  templateUrl: './create-test-form.component.html',
  styleUrls: ['./create-test-form.component.css']
})
export class CreateTestFormComponent implements OnInit {

  public myForm: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.myForm = this.formBuilder.group({
      title: ['', Validators.required],
      description: [''],
      questions: this.formBuilder.array([])
    });
  }

  initQuestion() {
    return this.formBuilder.group({
      street: [''],
      postcode: ['']
    });
  }

  addQuestion() {
    const control = <FormArray>this.myForm.controls['questions'];
    control.push(this.initQuestion());
  }

  save() {
    event.preventDefault();
    console.log('Form submit');
  }
}
