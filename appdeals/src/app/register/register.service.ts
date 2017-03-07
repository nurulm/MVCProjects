import {Injectable} from '@angular/core'

@Injectable()
export class RegisterService{

    GetCountries()
    {
        return [{ name: "India", code: "IN" }, { name: "Canada", code: "CA`" }];
    }
}