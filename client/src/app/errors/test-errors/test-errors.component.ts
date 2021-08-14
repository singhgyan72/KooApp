import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-errors',
  templateUrl: './test-errors.component.html',
  styleUrls: ['./test-errors.component.css']
})
export class TestErrorsComponent implements OnInit {
  baseUrl = 'http://localhost:5000/api/';

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  get404Error() {

  }
}
