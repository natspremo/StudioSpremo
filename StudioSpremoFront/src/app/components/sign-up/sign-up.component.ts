import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
  password: string = "";
  confirmpassword: string = "";
  name: string = "";
  surname: string = "";
  company: string = "";
  phone: string = "";
  address: string = "";
  email: string = "";

  reactiveForm: FormGroup = new FormGroup({
    'email': new FormControl('', [Validators.required, Validators.email]),
    'password': new FormControl('', [Validators.required, Validators.minLength(4)]),
    'confirmpassword': new FormControl('', [Validators.required, Validators.minLength(4)]),
    'name': new FormControl('', [Validators.required, Validators.maxLength(50)]),
    'surname': new FormControl('', [Validators.required, Validators.maxLength(50)]),
    'company': new FormControl('', [Validators.required, Validators.maxLength(50)]),
    'address': new FormControl('', [Validators.required, Validators.maxLength(50)]),
    'phone': new FormControl('', [Validators.required, Validators.maxLength(15)])

  });
  constructor() { }

  ngOnInit(): void {
  }

  onSubmit() {

  }
}
