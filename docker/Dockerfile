ARG DOTNET_VERSION
FROM mcr.microsoft.com/dotnet/aspnet:$DOTNET_VERSION

RUN apt-get update && apt-get -y install build-essential python3-dev python3-pip python3-setuptools python3-wheel python3-cffi libcairo2 libpango-1.0-0 libpangocairo-1.0-0 libgdk-pixbuf2.0-0 libffi-dev shared-mime-info
RUN rm -f /usr/lib/python*/EXTERNALLY-MANAGED

ARG WEASYPRINT_VERSION
RUN pip3 install WeasyPrint==$WEASYPRINT_VERSION
