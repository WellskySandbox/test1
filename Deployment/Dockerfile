FROM wellsky.azurecr.io/atlas-service:net6
WORKDIR /app
EXPOSE 443

COPY Build/output/service/publish .
ENTRYPOINT ["dotnet", "test1.dll"]