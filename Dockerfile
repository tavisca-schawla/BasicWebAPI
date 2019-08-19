FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
RUN ["powershell", "dotnet", "WebApi.dll"]