#!/bin/sh

############################################################################
# Script for installing a desktop and enabling remote desktop connections  #
############################################################################

# Updated apt-get
echo "Updating apt-get"
sudo apt-get -y update

# Install RDP
echo "Installing XRDP"
sudo apt-get -y install xrdp

# Install XFCE desktop
echo "Installing XFCE4"
sudo apt-get -y install xfce4

# Run RDP service
echo "Starting XRDP service"

# Finished
echo "Finished setting up remote desktop for this machine"