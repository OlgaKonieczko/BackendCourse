import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  backendResponse: string;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  sendRequestToBackend() {
    this.http.get("https://localhost:44371/" + "kurs" + "/getMessage").subscribe(response => { this.backendResponse = response.toString() }, error => {this.backendResponse = error });
  }

}