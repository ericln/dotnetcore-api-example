#!/usr/bin/env bash

echo "setup environment variables..."

export WIIVV_ENVIRONMENT=dev
export APP_NAME=${APP_NAME:-ms-netcore-batch}
export REPLICAS_COUNT=${REPLICAS_COUNT:-2}
export WIIVV_IMAGE_TAG=${CIRCLE_SHA1:-feature-circleci}
export REPO_URL=${REPO_URL:-037346530273.dkr.ecr.us-west-2.amazonaws.com}
