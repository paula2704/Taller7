FROM quay.io/wildfly/wildfly:latest-jdk21
COPY target/jakartaee-app-web.war /opt/jboss/wildfly/standalone/deployments/
