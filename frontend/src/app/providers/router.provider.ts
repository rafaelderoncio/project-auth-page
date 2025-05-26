import { provideRouter } from "@angular/router";
import { routes } from "../app.routes";
import { EnvironmentProviders } from "@angular/core";

export const routerProvider:EnvironmentProviders = provideRouter(routes);