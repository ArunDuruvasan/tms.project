
import { AuthenticationService } from "../../_services/authentication.service";
import { OnInit, Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs-compat/operator/first';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.scss"]
})
export class LoginComponent implements OnInit {
  model: any = {};
  loading = false;
  submitted = false;
  returnUrl: string;
  error = "";
  isContainerAttributeVisible : boolean=true;
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authenticationService: AuthenticationService,private SpinnerService: NgxSpinnerService
  ) {}

  ngOnInit() {
    // reset login status
    this.authenticationService.logout();
    // get return url from route parameters or default to '/'
    this.returnUrl = this.route.snapshot.queryParams["returnUrl"] || "/";
  }

  // convenience getter for easy access to form fields

  onSubmit() {
    this.loading = true;
    this.isContainerAttributeVisible = false;
    // stop here if form is invalid
this.SpinnerService.show();
    this.authenticationService
      .login(this.model.username, this.model.password, this.model.company)
      .pipe()
      .subscribe(
        data => {     
          this.router.navigate(["dashboard"]);
        },
        error => {
          this.error = "Error in Login!";
          this.loading = false;
          console.log("LOGIN ERROR: "+ error );
        }
      );
      this.SpinnerService.hide();
  }
}
