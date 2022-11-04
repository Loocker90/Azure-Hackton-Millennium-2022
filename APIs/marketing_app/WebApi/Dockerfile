FROM mcr.microsoft.com/dotnet/sdk:6.0
COPY ["WebApi.csproj", "webApi/"]
WORKDIR "webApi"
RUN dotnet restore "WebApi.csproj"
COPY . .
RUN dotnet build "WebApi.csproj" -c Release -o /app/build
EXPOSE 5010
CMD dotnet run "WebApi.csproj"
