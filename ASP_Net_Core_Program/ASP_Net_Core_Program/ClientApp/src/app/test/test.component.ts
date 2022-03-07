import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

export class Mess {
  content: string
  author :string
}

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
  //{ responseType: "text" } 
  //this.backendResponse = (response as any)

  sendRequestToBackend() {
    var message = new Mess();
    message.content = "JakaśWiadomosc";
    message.author = "Ja Olga"

    this.http.post("https://localhost:44371/" + "kurs" + "/sendMessage", message).subscribe(response =>
    { 
      this.backendResponse = (response as any).content;
    },
      error => {
        this.backendResponse = error
      });
      
  }

}
