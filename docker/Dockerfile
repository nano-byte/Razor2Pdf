ARG NETCORE_VERSION
FROM mcr.microsoft.com/dotnet/core/aspnet:$NETCORE_VERSION

RUN apt-get update && apt-get -y install build-essential python3-dev python3-pip python3-setuptools python3-wheel python3-cffi libcairo2 libpango-1.0-0 libpangocairo-1.0-0 libgdk-pixbuf2.0-0 libffi-dev shared-mime-info

ARG WEASYPRINT_VERSION
RUN pip3 install WeasyPrint==$WEASYPRINT_VERSION
