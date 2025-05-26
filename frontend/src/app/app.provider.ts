import { EnvironmentProviders } from "@angular/core";
import { zoneChangeDetectionProvider } from "./providers/zone-change-detection.provider";
import { routerProvider } from "./providers/router.provider";
import { httpClientProvider } from "./providers/http-client.provider";

export const appProviders: EnvironmentProviders[] = [
    zoneChangeDetectionProvider,
    routerProvider,
    httpClientProvider
];