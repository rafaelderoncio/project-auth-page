import { provideHttpClient, withInterceptorsFromDi } from "@angular/common/http";
import { EnvironmentProviders } from "@angular/core";

export const httpClientProvider: EnvironmentProviders = provideHttpClient(
      withInterceptorsFromDi());