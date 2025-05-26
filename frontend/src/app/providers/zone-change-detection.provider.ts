import { EnvironmentProviders, provideZoneChangeDetection } from "@angular/core";

export const zoneChangeDetectionProvider: EnvironmentProviders = provideZoneChangeDetection(
    { eventCoalescing: true }
);