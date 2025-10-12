from langchain_core.prompts import ChatPromptTemplate
from langchain_ollama import OllamaLLM
from langchain.callbacks import StdOutCallbackHandler
import logging
import sys

logging.basicConfig(
    level=logging.DEBUG,
    format="%(asctime)s - %(name)s - %(levelname)s - %(message)s",
    stream=sys.stdout,
)


class DetailedLoggingCallbackHandler(StdOutCallbackHandler):
    def __init__(self):
        super().__init__()
        self.logger = logging.getLogger("langchain_detailed")
        self.logger.setLevel(logging.DEBUG)
        self.file_logger = logging.getLogger("langchain_file_logger")

    def on_llm_start(self, serialized, prompts, **kwargs):
        message = f"Starting LLM with prompts: {prompts}"
        self.logger.info(message)
        self.file_logger.info(message)
        for idx, prompt in enumerate(prompts):
            prompt_message = f"Prompt {idx}: {prompt}"
            self.logger.debug(prompt_message)
            self.file_logger.debug(prompt_message)

    def on_llm_end(self, response, **kwargs):
        message = f"LLM finished with response: {response}"
        self.logger.info(message)
        self.file_logger.info(message)

    def on_llm_new_token(self, token, **kwargs):
        message = f"New token: {token}"
        self.logger.debug(message)
        self.file_logger.debug(message)

    def on_llm_error(self, error, **kwargs):
        message = f"LLM error: {error}"
        self.logger.error(message)
        self.file_logger.error(message)

    def on_chain_start(self, serialized, inputs, **kwargs):
        chain_name = serialized.get("name", "unnamed chain")
        message = f"Starting chain {chain_name} with inputs: {inputs}"
        self.logger.info(message)
        self.file_logger.info(message)

    def on_chain_end(self, outputs, **kwargs):
        message = f"Chain ended with outputs: {outputs}"
        self.logger.info(message)
        self.file_logger.info(message)

    def on_chain_error(self, error, **kwargs):
        message = f"Chain error: {error}"
        self.logger.error(message)
        self.file_logger.error(message)

    def on_tool_start(self, serialized, input_str, **kwargs):
        tool_name = serialized.get("name", "unnamed tool")
        message = f"Starting tool {tool_name} with input: {input_str}"
        self.logger.info(message)
        self.file_logger.info(message)

    def on_tool_end(self, output, **kwargs):
        message = f"Tool ended with output: {output}"
        self.logger.info(message)
        self.file_logger.info(message)

    def on_tool_error(self, error, **kwargs):
        message = f"Tool error: {error}"
        self.logger.error(message)
        self.file_logger.error(message)

    def on_text(self, text, **kwargs):
        message = f"Text: {text}"
        self.logger.info(message)
        self.file_logger.info(message)


template = """Question: {question}

Answer: Let's think step by step."""

prompt = ChatPromptTemplate.from_template(template)

callbacks = [
    DetailedLoggingCallbackHandler(),
    StdOutCallbackHandler(),
]

model = OllamaLLM(model="llama3.1", verbose=True, callbacks=callbacks)

chain = prompt | model

result = chain.invoke(
    {"question": "What is Canada?"}, callbacks=callbacks, verbose=True
)

print("\n\nFINAL RESULT:")
print(result)
