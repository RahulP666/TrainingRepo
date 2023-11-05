FROM mcr.microsoft.com/dotnet/sdk:5.0
FROM mcr.microsoft.com/dotnet/aspnet:5.0
# Create a directory within the container to host your web application

EXPOSE 80
EXPOSE 443

WORKDIR /app

# Copy your web application from the local folder to the container
COPY out .
RUN dir .

#RUN dotnet --version


CMD ["dotnet","MVCTraining.dll"]


