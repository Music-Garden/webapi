FROM mcr.microsoft.com/dotnet/sdk as base

WORKDIR /workspace
COPY . .
RUN dotnet publish --configuration Release --output out MusicGarden.Client

FROM mcr.microsoft.com/dotnet/aspnet

WORKDIR /workspace
COPY --from=base /workspace/out .
CMD [ "dotnet", "MusicGarden.Client.dll" ]