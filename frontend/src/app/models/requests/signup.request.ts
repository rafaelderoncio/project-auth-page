export interface SignUpRequest {
  firstName: string;
  lastName: string;
  gender: string;
  birthdate: Date;
  email: string;
  password: string;
  confirmPassword: string;
}
