#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Juridico.Subsidios.Acl.Application/Juridico.Subsidios.Acl.Application.csproj", "Juridico.Subsidios.Acl.Application/"]
COPY ["Juridico.Subsidios.Acl.Domain/Juridico.Subsidios.Acl.Domain.csproj", "Juridico.Subsidios.Acl.Domain/"]
COPY ["Juridico.Subsidios.Acl.Infrastucture/Juridico.Subsidios.Acl.Infrastucture.csproj", "Juridico.Subsidios.Acl.Infrastucture/"]
RUN dotnet restore "Juridico.Subsidios.Acl.Application/Juridico.Subsidios.Acl.Application.csproj"
COPY . .
WORKDIR "/src/Juridico.Subsidios.Acl.Application"
RUN dotnet build "Juridico.Subsidios.Acl.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Juridico.Subsidios.Acl.Application.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Juridico.Subsidios.Acl.Application.dll"]